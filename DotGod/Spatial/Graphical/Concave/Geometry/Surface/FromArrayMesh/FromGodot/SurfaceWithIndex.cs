using DotGod.Spatial.Graphical.Concave.Geometry._Material.FromArrayMesh;
using DotGod.Spatial.Graphical.Concave.Geometry.Polygon.Triangle.FromGodot.FromSurface;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Surface.FromArrayMesh.FromGodot;

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