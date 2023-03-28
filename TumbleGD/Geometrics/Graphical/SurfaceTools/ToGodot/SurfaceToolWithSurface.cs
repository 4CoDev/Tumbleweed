using Godot;
using TumbleGD.Geometrics.Graphical.Materials;
using TumbleGD.Geometrics.Graphical.Polygons;
using TumbleGD.Geometrics.Graphical.Surfaces;
using TumbleGD.Geometrics.Graphical.SurfaceTools.OfGodot.FromEnumerable;
using TumbleGD.Geometrics.Graphical.Vertices;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.SurfaceTools.ToGodot;

public sealed class SurfaceToolWithSurface : ScalarEnvelope<SurfaceTool>
{
	public SurfaceToolWithSurface(ISurface surface) : base
	(
		new AggregatedByExpression<IPolygon>(
			new PolygonsOfSurface(surface),
			new InitialSurfaceToolWithMaterial(
				new MaterialOfSurface(surface)),
			Expression)
	)
	{
	}

	private static IScalar<SurfaceTool> Expression
	(
		IScalar<SurfaceTool> current,
		IPolygon polygon
	) =>
	(
		new SurfaceToolWithPolygon(polygon, current)
	);
}