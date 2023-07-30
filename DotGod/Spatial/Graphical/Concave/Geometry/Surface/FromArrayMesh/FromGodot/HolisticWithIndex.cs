using DotGod.Spatial.Graphical.Concave.Geometry._Material.FromArrayMesh;
using DotGod.Spatial.Graphical.Concave.Geometry.Polygon.Triangle.FromGodot.FromSurface;
using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Surface.FromArrayMesh.FromGodot;

public sealed class HolisticWithIndex : SurfaceEnvelope
{
	public HolisticWithIndex
	(
		Any<ArrayMesh> mesh,
		Int32 index
	) : this
	(
		mesh,
		new Value<Int32>(index)
	)
	{
	}
	
	public HolisticWithIndex
	(
		Any<ArrayMesh> mesh,
		Any<Int32> index
	) : base
	(
		new SurfaceWithValues(
			new TrianglesOfHolistic(mesh, index),
			new MaterialOfSurface(mesh, index))
	)
	{
	}
}