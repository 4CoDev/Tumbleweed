using DotGod.Geometry.Graphical.Surfaces.FromArrayMeshes.FromGodot;
using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Graphical.Meshes.FromArrayMeshes.FromGodot;

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