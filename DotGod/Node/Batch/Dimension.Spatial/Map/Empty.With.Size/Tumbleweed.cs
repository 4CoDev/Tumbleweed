using Godot;
using Map = DotGod.Node.Batch.Dimension.Spatial.Map;
using Vector = Tumbleweed.Mathematics.Vector.Spatial;
using Number = Tumbleweed.Mathematics.Number;
using Batch = DotGod.Node.Batch.Dimension.Spatial.Measurement.Unmeasured;

namespace DotGod.Node.Batch.Dimension.Spatial.Map.Empty.With.Size;

public sealed class Tumbleweed : Map::Envelope
{
	public Tumbleweed
	(
		Vector::Generic.Any<Number::Real.Any> size
	) : base
	(
		new Map::With.Members.One(
			new Batch::Empty.One(),
			size)
	)
	{
	}
}