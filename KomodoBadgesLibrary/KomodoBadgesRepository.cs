using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoBadgesLibrary
{
    class KomodoBadgesRepository
    {
        abstract public class BadgesRepository
        {
            //Properties
            private List<BadgeClassProperties> _PropertiesRepository = new List<BadgeClassProperties>();

            //Create
            public void AddBadgeToRepository(BadgeClassProperties passedBadge)
            {
                _PropertiesRepository.Add(passedBadge);
            }

            //Read
            public List<BadgeClassProperties> GetBadges()
            {
                return _PropertiesRepository;
            }

            public BadgeClassProperties GetBadgeClassPropertiesById(int id)
            {
                foreach (var bad in _PropertiesRepository)
                {
                    if (bad.ID == id)
                    {
                        return bad;
                    }
                }
                return null;
            }

            public bool RepositoryContainsProperties(int id)
            {
                return _PropertiesRepository.Contains(GetBadgeClassPropertiesById(id));
            }

            //Update
            public bool UpdateRepositoryObjectById(int originalId, BadgeClassProperties newBadgeClassProperties)
            {
                BadgeClassProperties originalBadgeClassProperties = GetBadgeClassPropertiesById(originalId);
                if (originalBadgeClassProperties != null)
                {
                    int originalBadgeClassPropertiesIndex = _PropertiesRepository.IndexOf(originalBadgeClassProperties);
                    _PropertiesRepository[originalBadgeClassPropertiesIndex] = newBadgeClassProperties;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            //Delete
            public bool RemoveRepositoryObjectById(int id)
            {
                BadgeClassProperties content = GetBadgeClassPropertiesById(id);
                if (content == null)
                {
                    return false;
                }

                int initialCount = _PropertiesRepository.Count;
                _PropertiesRepository.Remove(content);
                if (initialCount > _PropertiesRepository.Count)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        public class KomodoBadges : BadgesRepository
        {
            
            public List<Door> GetBadgesInRepository()
            {
                List<Door> devListToReturn = new List<Door>();
                List<BadgeClassProperties> badgeClassProperties = GetBadgeClassProperties();
                foreach (var businessObject in badgeClassProperties)
                {
                    devListToReturn.Add((Door)badgeClassProperties);
                }
                return devListToReturn;
            }

            public List<Badges> GetBadgesWithoutAccess()
            {
                List<CurrentDoors> currentDoorsInRepo = GetDoorsInRepository();
                List<BadgesWithNoAccess> badgesWithoutAccess = new List<Door>();

                foreach (Badge badg in currentBadgesInRepo)
                {
                    if (badg.HasAccess == false)
                    {
                        badgesWithoutAccess.Add(dev);
                    }
                }
                return badgesWithoutAccess;
            }
        }

        public class DoorsInRepository : BadgesRepository
        {
            
            public List<Badges> GetBadgesInRepository()
            {
                List<Badges> DoorAccessToReturn = new List<DoorAccess>();
                List<BadgeClassProperties> businessObjects = BadgeClassProperties();
                foreach (var badgeClassProperties in badgeClassProperties)
                {
                    BadgesToReturn.Add((Badges)businessObject);
                }
                return BadgesToReturn;
            }

            public Badges GetBadgesById(int id)
            {
                List<BadgeClassProperties> businessObjects = BadgeClassProperties();
                foreach (var badgeClassProperties in badgeClassProperties)
                {
                    if (badgeClassProperties.ID == id)
                    {
                        return (Badges)businessObject;
                    }
                }
                return null;


            }
    }
}
