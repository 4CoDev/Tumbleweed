using DotGod.Geometry.Spatial.Graphical.Surface.FromArrayMesh.FromGodot;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Geometry.Spatial.Graphical._Mesh.FromArrayMesh.FromGodot;

public sealed class HolisticFromGodot : MeshEnvelope
{
	public HolisticFromGodot(ArrayMesh mesh) : this
	(
		new ScalarValue<ArrayMesh>(mesh)
	)
	{
	}
	
	public HolisticFromGodot(IScalar<ArrayMesh> mesh) : base
	(
		new MeshWithSurfaces(
			new HolisticsFromMesh(mesh))
	)
	{
	}
}