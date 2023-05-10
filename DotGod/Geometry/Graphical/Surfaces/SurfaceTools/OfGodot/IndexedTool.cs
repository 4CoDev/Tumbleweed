using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Graphical.Surfaces.SurfaceTools.OfGodot;

public sealed class IndexedTool : IScalar<SurfaceTool>
{
	public IndexedTool(IScalar<SurfaceTool> origin)
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