using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicTrade.Entities.EntityEnums.UserRoleType
{
    public enum RoleType : byte
    {
        customerservice_staff=1,
        advertisement_staff=2,
        qualitycontrol_staff=3,
        financialaccounting_staff=4,
        logistic_staff=5,
        humanresources_staff=6,
        informationtechnology_staff=7,
        salesmarketing_staff=8,

        customerservice_manager = 11,
        advertisement_manager = 22,
        qualitycontrol_manager = 33,
        financialaccounting_manager = 44,
        logistic_manager = 55,
        humanresources_manager = 66,
        informationtechnology_manager = 77,
        salesmarketing_manager = 88,

        chiefexecutiveofficer=98,
        boardofdirectors=100
    }
}
