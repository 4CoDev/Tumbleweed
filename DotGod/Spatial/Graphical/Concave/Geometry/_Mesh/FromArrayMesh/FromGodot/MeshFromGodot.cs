using DotGod.Spatial.Graphical.Concave.Geometry._Mesh._ArrayMesh.OfGodot;
using DotGod.Spatial.Graphical.Concave.Geometry.Surface.FromArrayMesh.FromGodot;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry._Mesh.FromArrayMesh.FromGodot;

public sealed class MeshFromGodot : MeshEnvelope
{
	public MeshFromGodot(Godot.Mesh mesh) : this
	(
		new ScalarValue<Godot.Mesh>(mesh)
	)
	{
	}
	
	public MeshFromGodot(IScalar<Godot.Mesh> mesh) : this
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