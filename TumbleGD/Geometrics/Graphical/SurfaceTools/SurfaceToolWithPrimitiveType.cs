using Godot;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.SurfaceTools;

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