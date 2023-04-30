using Tumbleweed.Numbers.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Arithmetics;

public sealed class MinimumOfTwoSpatials : ISpatial<IReal>
{
	public MinimumOfTwoSpatials
	(
		ISpatial<IReal> first,
		ISpatial<IReal> second
	)
	{
		this.first = first;
		this.second = second;
	}
	
	public IReal X => first.X;

	public IReal Y => throw new NotImplementedException();

	public IReal Z => throw new NotImplementedException();

	private readonly ISpatial<IReal> first, second;
}