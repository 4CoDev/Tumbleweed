using Tumbleweed.Mathematics.Number.Real;
using Property = Tumbleweed.Property.Output;
using Godot = Godot;

namespace DotGod.Mathematics.Vector.Spatial.Godot.From.Tumbleweed;

public sealed class One : Property::Envelope<Godot::Vector3>
{
	public One(global::Tumbleweed.Mathematics.Vector.Spatial.Generic.Any<Any> point) : base
	(
		new Property::Function.Result.Actual<Godot::Vector3>(
			() => Result(point))
	)
	{
	}

	private static Godot::Vector3 Result
	(global::Tumbleweed.Mathematics.Vector.Spatial.Generic.Any<Any> point
	) =>
	(
		new Godot::Vector3(
			new global::Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.From.Tumbleweed.One(point.X).Value,
			new global::Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.From.Tumbleweed.One(point.Y).Value,
			new global::Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.From.Tumbleweed.One(point.Z).Value)
	);
}