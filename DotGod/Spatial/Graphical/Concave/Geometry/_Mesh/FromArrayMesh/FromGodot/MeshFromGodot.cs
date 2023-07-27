using DotGod.Spatial.Graphical.Concave.Geometry._Mesh._ArrayMesh.OfGodot;
using DotGod.Spatial.Graphical.Concave.Geometry.Surface.FromArrayMesh.FromGodot;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry._Mesh.FromArrayMesh.FromGodot;

public sealed class MeshFromGodot : MeshEnvelope
{
	public MeshFromGodot(Godot.Mesh mesh) : this
	(
		new Tumbleweed.Scalar.Of.Value<Godot.Mesh>(mesh)
	)
	{
	}
	
	public MeshFromGodot(Any<Godot.Mesh> mesh) : this
	(
		new ArrayMeshFromMesh(mesh)
	)
	{
	}
	
	public MeshFromGodot(ArrayMesh mesh) : this
	(
		new Tumbleweed.Scalar.Of.Value<ArrayMesh>(mesh)
	)
	{
	}
	
	public MeshFromGodot(Any<ArrayMesh> mesh) : base
	(
		new MeshWithSurfaces(
			new SurfacesFromMesh(mesh))
	)
	{
	}
}