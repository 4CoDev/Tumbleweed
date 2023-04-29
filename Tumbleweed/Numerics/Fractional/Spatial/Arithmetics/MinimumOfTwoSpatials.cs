using Tumbleweed.Numerics.Spatial;

namespace Tumbleweed.Numerics.Fractional.Spatial.Arithmetics;

public sealed class MinimumOfTwoSpatials : ISpatial<IFractional>
{
	public MinimumOfTwoSpatials
	(
		ISpatial<IFractional> first,
		ISpatial<IFractional> second
	)
	{
		this.first = first;
		this.second = second;
	}
	
	public IFractional X => first.X;

	public IFractional Y => throw new NotImplementedException();

	public IFractional Z => throw new NotImplementedException();

	private readonly ISpatial<IFractional> first, second;
}