using Godot;
using TumbleGD.Geometrics.Graphical.Vertices;
using TumbleGD.Numerics.Decimals.Planars.ToGodot;
using TumbleGD.Numerics.Decimals.Spatials.ToGodot;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.SurfaceTools.
	ToGodot;

public sealed class SurfaceToolWithVertex : IScalar<SurfaceTool>
{
	public SurfaceToolWithVertex(IScalar<SurfaceTool> tool, IVertex vertex)
	{
		this.tool = tool;
		this.vertex = vertex;
	}

	public SurfaceTool Value
	{
		get
		{
			SurfaceTool result = tool.Value;
			result.SetNormal(new Vector3FromSpatial(vertex.Normal).Value);
			result.SetColor(vertex.Color.Value);
			result.SetUV(new Vector2FromPlanar(vertex.UV).Value);
			result.AddVertex(new Vector3FromSpatial(vertex.Translation).Value);
			return result;
		}
	}

	private readonly IScalar<SurfaceTool> tool;
	
	private readonly IVertex vertex;
}