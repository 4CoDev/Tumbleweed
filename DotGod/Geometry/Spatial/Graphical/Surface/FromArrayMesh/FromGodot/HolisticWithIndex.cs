using DotGod.Geometry.Spatial.Graphical._Material.FromArrayMesh;
using DotGod.Geometry.Spatial.Graphical.Polygon.Triangle.FromGodot.FromSurface;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Geometry.Spatial.Graphical.Surface.FromArrayMesh.FromGodot;

public sealed class HolisticWithIndex : SurfaceEnvelope
{
	public HolisticWithIndex
	(
		IScalar<ArrayMesh> mesh,
		Int32 index
	) : this
	(
		mesh,
		new ScalarValue<Int32>(index)
	)
	{
	}
	
	public HolisticWithIndex
	(
		IScalar<ArrayMesh> mesh,
		IScalar<Int32> index
	) : base
	(
		new SurfaceWithValues(
			new TrianglesOfHolistic(mesh, index),
			new MaterialOfSurface(mesh, index))
	)
	{
	}
}