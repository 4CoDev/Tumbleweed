using Godot;
using TumbleGD.Geometrics.Graphical.Materials.FromArrayMesh;
using TumbleGD.Geometrics.Graphical.Polygons.FromSurface;
using TumbleGD.Geometrics.Graphical.Surfaces;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Polygons.FromArrayMesh;

public sealed class SurfaceWithIndex : SurfaceEnvelope
{
	public SurfaceWithIndex(IScalar<ArrayMesh> mesh, IScalar<Int32> index) : base
	(
		new SurfaceWithValues(
			new TrianglesOfSurface(mesh, index),
			new MaterialOfSurface(mesh, index))
	)
	{
	}
}