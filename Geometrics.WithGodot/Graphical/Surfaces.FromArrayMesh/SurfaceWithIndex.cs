using Godot;
using Tumbleweed.Geometrics.Graphical.Surfaces;
using Tumbleweed.Geometrics.WithGodot.Graphical.Materials.FromArrayMesh;
using Tumbleweed.Geometrics.WithGodot.Graphical.Polygons.FromArrayMesh.FromSurface;
using Tumbleweed.Scalars;

namespace Tumbleweed.Geometrics.WithGodot.Graphical.Surfaces.FromArrayMesh;

public sealed class SurfaceWithIndex : SurfaceEnvelope
{
	public SurfaceWithIndex(IScalar<ArrayMesh> mesh, IScalar<int> index) : base
	(
		new SurfaceWithValues(
			new TrianglesOfSurface(mesh, index),
			new MaterialOfSurface(mesh, index))
	)
	{
	}
}