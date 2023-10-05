using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.SurfaceTool.With.PrimitiveType.Set;

public sealed class One : Any<Godot.SurfaceTool>
{
	public One
	(
		Any<Godot.Mesh.PrimitiveType> type
	) : this
	(
		new New<Godot.SurfaceTool>(), type
	)
	{
	}
	
	public One
	(
		Any<Godot.SurfaceTool> origin,
		Any<Godot.Mesh.PrimitiveType> type
	)
	{
		this.origin = origin;
		this.type = type;
	}

	public Godot.SurfaceTool Value
	{
		get
		{
			Godot.SurfaceTool result = origin.Value;
			result.Begin(type.Value);
			return result;
		}
	}

	private readonly Any<Godot.SurfaceTool> origin;
	
	private readonly Any<Godot.Mesh.PrimitiveType> type;
}