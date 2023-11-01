using Tumbleweed.Property.Output.Function.Result;
using Tumbleweed.Subroutine.Function.Nullary.From;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.Mesh.Function.Result;

public sealed class One : Envelope
{
	public One(Func<Any> function) : this
	(
		new System<Any>(function)
	)
	{
	}
	
	public One(Tumbleweed.Subroutine.Function.Nullary.Any<Any> function) : base
	(
		new Property.Value.One(
			new Actual<Any>(function))
	)
	{
	}
}