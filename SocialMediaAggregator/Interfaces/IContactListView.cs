//
// Free to redistribute and use.
// Creator: Gentiana Coman, www.gentianacoman.com
//

using SocialMediaAggregator.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaAggregator.Interfaces
{
    /// <summary>
    /// An interface required by any object that handles a contact list.
    /// </summary>
    public interface IContactListView
    {
        void LoadContacts(IEnumerable<UserInfo> users);
    }
}
