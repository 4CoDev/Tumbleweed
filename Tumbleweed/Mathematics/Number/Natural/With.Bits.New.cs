// ReSharper disable once CheckNamespace

using Tumbleweed.Mathematics.Number.Natural;

namespace Tumbleweed.Mathematics.Number.Natural.With.Bits;

public sealed class New : Any
{
	public New(IEnumerable<Boolean.Any> bits) =>
		Bits = bits;
	
	public IEnumerable<Boolean.Any> Bits { get; }
}