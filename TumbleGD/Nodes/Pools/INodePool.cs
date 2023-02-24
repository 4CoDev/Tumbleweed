using TumbleGD.Dictionaries;
using Tumbleweed.Delegates.Actions;

namespace TumbleGD.Nodes.Pools;

public interface INodePool
{
	IDictionary<object, IAction> Graphicals { get; }
	
	IDictionary<object, IAction> Physicals { get; }
	
	IDictionary<object, IAction> Inputs { get; }
	
	IDictionary<object, object> Listenings { get; }
}