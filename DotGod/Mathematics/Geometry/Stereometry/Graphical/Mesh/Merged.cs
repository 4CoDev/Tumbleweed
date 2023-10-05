using DotGod.Mathematics.Geometry.Stereometry.Graphical.Mesh.With.Surfaces;
using Tumbleweed.Enumerable;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.Mesh;

public sealed class Merged : Envelope
{
	public Merged(IEnumerable<Any> meshes) : base
	(
		new One(
			new Concatenated<Graphical.Surface.Any>(
				new Selected<Any, IEnumerable<Graphical.Surface.Any>>(
					meshes,
					mesh => mesh.Surfaces)))
	)
	{
	}
}