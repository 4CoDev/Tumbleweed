using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Surface._SurfaceTool.OfGodot;

public sealed class ToolWithPrimitiveType : Any<SurfaceTool>
{
	public ToolWithPrimitiveType
	(
		Any<Godot.Mesh.PrimitiveType> type
	) : this
	(
		new Tumbleweed.Scalar.Of.New<SurfaceTool>(), type
	)
	{
	}
	
	public ToolWithPrimitiveType
	(
		Any<SurfaceTool> origin,
		Any<Godot.Mesh.PrimitiveType> type
	)
	{
		this.origin = origin;
		this.type = type;
	}

	public SurfaceTool Value
	{
		get
		{
			SurfaceTool result = origin.Value;
			result.Begin(type.Value);
			return result;
		}
	}

	private readonly Any<SurfaceTool> origin;
	
	private readonly Any<Godot.Mesh.PrimitiveType> type;
}