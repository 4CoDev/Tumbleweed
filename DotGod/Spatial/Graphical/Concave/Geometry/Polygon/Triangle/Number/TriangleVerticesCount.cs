using Tumbleweed.Number.Natural;
using Tumbleweed.Number.Natural.From.System;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Polygon.Triangle.Number;

public sealed class TriangleVerticesCount : Envelope
{
	public TriangleVerticesCount() : base
	(
		new One(
			new OfSystem.TriangleVerticesCount())
	)
	{
	}
}