using Godot;
using Tumbleweed.Number.Real;
using Tumbleweed.Number.Real.Binary.Precision.Double.From.System;
using Tumbleweed.Scalar;

namespace DotGod.Time;

public sealed class FrameTime : Envelope
{
	public FrameTime(Node node) : this
	(
		new Tumbleweed.Scalar.Of.Value<Node>(node)
	)
	{
	}
	
	public FrameTime(Any<Node> node) : base
	(
		new One(
			new ToSystem.FrameTime(node))
	)
	{
	}
}