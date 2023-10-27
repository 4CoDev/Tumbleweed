using Godot;
using Boolean = Tumbleweed.Mathematics.Boolean;
using Batch = DotGod.Node.Batch.Dimension.Spatial.Measurement.Measured;
using Aabb = Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb;

namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Measured.Is.Inside.Aabb;

public sealed class One : Boolean::Envelope
{
	public One
	(
		Batch::Any batch,
		Aabb::Any aabb
	) : base
	(
		new Aabb::Is.Inside.Other.One(
			aabb,
			new Batch::Member.Aabb.One(batch))
	)
	{
		var aabb1 = new Batch::Member.Aabb.One(batch);
		var a = aabb1.A;
		var b = aabb1.B;
		GD.Print(
			new Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.From
				.Tumbleweed.One(a.X).Value);
		GD.Print(
			new Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.From
				.Tumbleweed.One(a.Y).Value);
		GD.Print(
			new Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.From
				.Tumbleweed.One(a.Z).Value);
		GD.Print(
			new Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.From
				.Tumbleweed.One(b.X).Value);
		GD.Print(
			new Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.From
				.Tumbleweed.One(b.Y).Value);
		GD.Print(
			new Tumbleweed.Mathematics.Number.Real.Binary.Precision.Single.System.From
				.Tumbleweed.One(b.Z).Value);
	}
}