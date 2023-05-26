using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Geometry.Spatial.Graphical.Surface._SurfaceTool.OfGodot;

public sealed class ToolWithPrimitiveType : IScalar<SurfaceTool>
{
	public ToolWithPrimitiveType
	(
		IScalar<Mesh.PrimitiveType> type
	) : this
	(
		new ScalarOfNew<SurfaceTool>(), type
	)
	{
	}
	
	public ToolWithPrimitiveType
	(
		IScalar<SurfaceTool> origin,
		IScalar<Mesh.PrimitiveType> type
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
	
	private readonly IScalar<Mesh.PrimitiveType> type;
}