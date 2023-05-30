using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Surface._SurfaceTool.OfGodot;

public sealed class ToolWithPrimitiveType : IScalar<SurfaceTool>
{
	public ToolWithPrimitiveType
	(
		IScalar<Godot.Mesh.PrimitiveType> type
	) : this
	(
		new ScalarOfNew<SurfaceTool>(), type
	)
	{
	}
	
	public ToolWithPrimitiveType
	(
		IScalar<SurfaceTool> origin,
		IScalar<Godot.Mesh.PrimitiveType> type
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

	private readonly IScalar<SurfaceTool> origin;
	
	private readonly IScalar<Godot.Mesh.PrimitiveType> type;
}