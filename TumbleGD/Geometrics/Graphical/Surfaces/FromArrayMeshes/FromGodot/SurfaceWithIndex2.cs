using Godot;
using TumbleGD.Geometrics.Graphical.Materials.FromArrayMesh;
using TumbleGD.Geometrics.Graphical.Polygons.Triangles.FromGodot.FromSurface;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Surfaces.FromArrayMeshes.FromGodot;

public sealed class SurfaceWithIndex2 : SurfaceEnvelope
{
	public SurfaceWithIndex2
	(
		IScalar<ArrayMesh> mesh,
		Int32 index
	) : this
	(
		mesh,
		new ScalarOfValue<Int32>(index)
	)
	{
	}
	
	public SurfaceWithIndex2
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