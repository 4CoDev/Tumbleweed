using Tumbleweed.Mathematics.Geometry.Stereometry.Vertex;
using Property = Tumbleweed.Property.Output;
using Godot = Godot;

namespace DotGod.Mathematics.Geometry.Stereometry.Basic.Vertex.Member.Translation.Vector;

public sealed class One : Property::Envelope<Godot::Vector3>
{
	public One(Any vertex) : base
	(
		new Mathematics.Vector.Spatial.Godot.From.Tumbleweed.One(
			new Tumbleweed.Mathematics.Geometry.Stereometry.Vertex.Member.Translation.One(vertex))
	)
	{
	}
}