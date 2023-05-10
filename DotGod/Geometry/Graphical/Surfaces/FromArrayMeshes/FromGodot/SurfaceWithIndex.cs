using DotGod.Geometry.Graphical.Materials.FromArrayMesh;
using DotGod.Geometry.Graphical.Polygons.Triangles.FromGodot.FromSurface;
using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Graphical.Surfaces.FromArrayMeshes.FromGodot;

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