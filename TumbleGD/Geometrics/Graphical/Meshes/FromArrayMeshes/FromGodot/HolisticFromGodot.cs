using Godot;
using TumbleGD.Geometrics.Graphical.Surfaces.FromArrayMeshes.FromGodot;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Meshes.FromArrayMeshes.FromGodot;

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