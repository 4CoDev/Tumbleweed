using DotGod.Spatial.Graphical.Concave.Geometry.Surface.FromArrayMesh.FromGodot;
using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Spatial.Graphical.Concave.Geometry._Mesh.FromArrayMesh.FromGodot;

public sealed class HolisticFromGodot : MeshEnvelope
{
	public HolisticFromGodot(ArrayMesh mesh) : this
	(
		new Value<ArrayMesh>(mesh)
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