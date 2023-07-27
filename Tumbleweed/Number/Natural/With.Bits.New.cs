// ReSharper disable once CheckNamespace
namespace Tumbleweed.Number.Natural.With.Bits;

public sealed class New : Natural.Any
{
	public New(IEnumerable<Boolean.Any> bits) =>
		Bits = bits;
	
	public IEnumerable<Boolean.Any> Bits { get; }
}