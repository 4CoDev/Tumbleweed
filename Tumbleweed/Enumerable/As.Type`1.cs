using Enumerable = Tumbleweed.Enumerable;
using System = System.Collections;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Enumerable.As;

public sealed class Type<T> : Enumerable::Envelope<T>
{
	public Type(System::IEnumerable enumerable) : base
	(
		new Enumerable::Function.Result<T>(
			enumerable.Cast<T>)
	)
	{
	}
}