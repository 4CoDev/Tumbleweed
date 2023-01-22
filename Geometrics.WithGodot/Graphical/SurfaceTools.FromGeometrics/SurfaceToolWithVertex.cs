using Godot;
using Tumbleweed.Geometrics.Graphical.Vertices;
using Tumbleweed.Measurement.Planars.Scalars;
using Tumbleweed.Measurement.Spatials.Scalar;
using Tumbleweed.Scalars;

namespace Tumbleweed.Geometrics.WithGodot.Graphical.SurfaceTools.
	FromGeometrics;

public sealed class SurfaceToolWithVertex : IScalar<SurfaceTool>
{
	public SurfaceToolWithVertex(IScalar<SurfaceTool> tool, IVertex vertex)
	{
		this.tool = tool;
		this.vertex = vertex;
	}
	
	public SurfaceTool Value()
	{
		SurfaceTool result = tool.Value();
		result.SetNormal(new Vector3FromSpatial(vertex.Normal).Value());
		result.SetColor(vertex.Color.Value());
		result.SetUv(new Vector2FromPlanar(vertex.UV).Value());
		result.AddVertex(new Vector3FromSpatial(vertex.Translation).Value());
		return result;
	}
	
	private readonly IScalar<SurfaceTool> tool;
	
	private readonly IVertex vertex;
}