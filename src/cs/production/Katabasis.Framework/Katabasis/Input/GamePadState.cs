// Copyright (c) Craftworkgames (https://github.com/craftworkgames). All rights reserved.
// Licensed under the MS-PL license. See LICENSE file in the Git repository root directory (https://github.com/craftworkgames/Katabasis) for full license information.
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

namespace Katabasis
{
	[SuppressMessage("ReSharper", "UnusedMember.Global", Justification = "TODO: Needs tests.")]
	public struct GamePadState
	{
		public bool IsConnected { get; internal set; }

		public int PacketNumber { get; internal set; }

		public GamePadButtons Buttons { get; internal set; }

		public GamePadDPad DPad { get; internal set; }

		public GamePadThumbSticks ThumbSticks { get; internal set; }

		public GamePadTriggers Triggers { get; internal set; }

		public GamePadState(
			GamePadThumbSticks thumbSticks,
			GamePadTriggers triggers,
			GamePadButtons buttons,
			GamePadDPad dPad)
			: this()
		{
			ThumbSticks = thumbSticks;
			Triggers = triggers;
			Buttons = buttons;
			DPad = dPad;
			IsConnected = true;
			PacketNumber = 0;
		}

		public GamePadState(
			Vector2 leftThumbStick,
			Vector2 rightThumbStick,
			float leftTrigger,
			float rightTrigger,
			params Buttons[] buttons)
			: this(
				new GamePadThumbSticks(leftThumbStick, rightThumbStick),
				new GamePadTriggers(leftTrigger, rightTrigger),
				GamePadButtons.FromButtonArray(buttons),
				GamePadDPad.FromButtonArray(buttons))
		{
		}

		public bool IsButtonDown(Buttons button) => (Buttons._buttons & button) == button;

		public bool IsButtonUp(Buttons button) => (Buttons._buttons & button) != button;

		public static bool operator ==(GamePadState left, GamePadState right) =>
			left.IsConnected == right.IsConnected &&
			left.PacketNumber == right.PacketNumber &&
			left.Buttons == right.Buttons &&
			left.DPad == right.DPad &&
			left.ThumbSticks == right.ThumbSticks &&
			left.Triggers == right.Triggers;

		public static bool operator !=(GamePadState left, GamePadState right) => !(left == right);

		public override bool Equals(object? obj) => obj is GamePadState state && this == state;

		public override int GetHashCode() => base.GetHashCode();
	}
}
