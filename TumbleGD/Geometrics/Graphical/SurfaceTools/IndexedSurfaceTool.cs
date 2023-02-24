using Godot;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.SurfaceTools;

public sealed class IndexedSurfaceTool : IScalar<SurfaceTool>
{
	public IndexedSurfaceTool(IScalar<SurfaceTool> origin)
	{
		this.origin = origin;
	}

	public SurfaceTool Value
	{
		get
		{
			SurfaceTool indexed = origin.Value;
			indexed.Index();
			return indexed;
		}
	}

	private readonly IScalar<SurfaceTool> origin;
}