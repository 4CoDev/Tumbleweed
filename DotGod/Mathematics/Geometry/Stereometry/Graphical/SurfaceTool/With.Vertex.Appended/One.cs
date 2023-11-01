using DotGod.Mathematics.Geometry.Stereometry.Graphical.Vertex;
using Tumbleweed.Property.Output;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.SurfaceTool.With.Vertex.
	Appended;

public sealed class One : Any<Godot.SurfaceTool>
{
	public One(Any<Godot.SurfaceTool> tool, Any vertex)
	{
		this.tool = tool;
		this.vertex = vertex;
	}

	public Godot.SurfaceTool Value
	{
		get
		{
			Godot.SurfaceTool result = tool.Value;
			result.SetNormal(new Vector.Spatial.Godot.From.Tumbleweed.One(vertex.Normal).Value);
			result.SetColor(vertex.Color.Value);
			result.SetUV(new Vector.Planar.Godot.From.Tumbleweed.One(vertex.UV).Value);
			result.AddVertex(new Vector.Spatial.Godot.From.Tumbleweed.One(vertex.Translation).Value);
			return result;
		}
	}

	private readonly Any<Godot.SurfaceTool> tool;
	
	private readonly Any vertex;
}