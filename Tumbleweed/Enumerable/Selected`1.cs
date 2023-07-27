using Enumerable = Tumbleweed.Enumerable;
using System = System;

namespace Tumbleweed.Enumerable;

public sealed class Selected<T> : Enumerable::Envelope<T>
{
	public Selected
	(
		System::Collections.Generic.IEnumerable<T> from,
		System::Func<T, T> expression
	) : base
	(
		new Selected<T, T>(from, expression)
	)
	{
	}
}