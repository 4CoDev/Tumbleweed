using DotGod.Spatial.Graphical.Concave.Geometry.Surface.FromArrayMesh.FromGodot;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry._Mesh.FromArrayMesh.FromGodot;

public sealed class HolisticFromGodot : MeshEnvelope
{
	public HolisticFromGodot(ArrayMesh mesh) : this
	(
		new Tumbleweed.Scalar.Of.Value<ArrayMesh>(mesh)
	)
	{
	}
	
	public HolisticFromGodot(Any<ArrayMesh> mesh) : base
	(
		new MeshWithSurfaces(
			new HolisticsFromMesh(mesh))
	)
	{
	}
}