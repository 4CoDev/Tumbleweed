using DotGod.Geometrics.Graphical.Meshes.ArrayMeshes.OfGodot;
using DotGod.Geometrics.Graphical.Surfaces.FromArrayMeshes.FromGodot;
using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Geometrics.Graphical.Meshes.FromArrayMeshes.FromGodot;

public sealed class MeshFromGodot : MeshEnvelope
{
	public MeshFromGodot(Mesh mesh) : this
	(
		new ScalarValue<Mesh>(mesh)
	)
	{
	}
	
	public MeshFromGodot(IScalar<Mesh> mesh) : this
	(
		new ArrayMeshFromMesh(mesh)
	)
	{
	}
	
	public MeshFromGodot(ArrayMesh mesh) : this
	(
		new ScalarValue<ArrayMesh>(mesh)
	)
	{
	}
	
	public MeshFromGodot(IScalar<ArrayMesh> mesh) : base
	(
		new MeshWithSurfaces(
			new SurfacesFromMesh(mesh))
	)
	{
	}
}