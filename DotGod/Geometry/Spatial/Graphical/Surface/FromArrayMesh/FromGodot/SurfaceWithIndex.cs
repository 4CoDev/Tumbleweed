using DotGod.Geometry.Spatial.Graphical._Material.FromArrayMesh;
using DotGod.Geometry.Spatial.Graphical.Polygon.Triangle.FromGodot.FromSurface;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Geometry.Spatial.Graphical.Surface.FromArrayMesh.FromGodot;

public sealed class SurfaceWithIndex : SurfaceEnvelope
{
	public SurfaceWithIndex
	(
		IScalar<ArrayMesh> mesh,
		Int32 index
	) : this
	(
		mesh, new ScalarValue<Int32>(index)
	)
	{
	}
	
	public SurfaceWithIndex
	(
		IScalar<ArrayMesh> mesh,
		IScalar<Int32> index
	) : base
	(
		new SurfaceWithValues(
			new TrianglesOfSurface(mesh, index),
			new MaterialOfSurface(mesh, index))
	)
	{
	}
}