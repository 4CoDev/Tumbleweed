using Godot;
using TumbleGD.Geometrics.Graphical.Materials.FromArrayMesh;
using TumbleGD.Geometrics.Graphical.Polygons.Triangles.FromGodot.FromSurface;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Surfaces.FromArrayMeshes.FromGodot;

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