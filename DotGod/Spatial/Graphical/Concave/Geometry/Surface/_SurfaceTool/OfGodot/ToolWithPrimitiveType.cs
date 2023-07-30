using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Surface._SurfaceTool.OfGodot;

public sealed class ToolWithPrimitiveType : Any<SurfaceTool>
{
	public ToolWithPrimitiveType
	(
		Any<Godot.Mesh.PrimitiveType> type
	) : this
	(
		new New<SurfaceTool>(), type
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