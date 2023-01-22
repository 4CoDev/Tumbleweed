using Godot;
using Tumbleweed.Scalars;

namespace Tumbleweed.WithGodot.SurfaceTools;

public sealed class SurfaceToolWithPrimitiveType : IScalar<SurfaceTool>
{
	public SurfaceToolWithPrimitiveType
	(
		IScalar<Mesh.PrimitiveType> type
	) : this
	(
		new ScalarOfNew<SurfaceTool>(), type
	)
	{
	}
	
	public SurfaceToolWithPrimitiveType
	(
		IScalar<SurfaceTool> origin,
		IScalar<Mesh.PrimitiveType> type
	)
	{
		this.origin = origin;
		this.type = type;
	}

	public SurfaceTool Value()
	{
		SurfaceTool result = origin.Value();
		result.Begin(type.Value());
		return result;
	}
	
	private readonly IScalar<SurfaceTool> origin;
	
	private readonly IScalar<Mesh.PrimitiveType> type;
}