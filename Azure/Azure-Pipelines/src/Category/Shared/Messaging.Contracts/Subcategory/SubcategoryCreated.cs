﻿using System;

namespace Category.Shared.Messaging.Contracts.Subcategory
{
    public interface SubcategoryCreated
    {
        byte HierarchyId { get; }
        string HierarchyName { get; }

        int CategoryId { get; }
        string CategoryName { get; }

        int Id { get; }
        string Name { get; }
        DateTime CreatedDate { get; }
        bool Active { get; }

        string User { get; }
    }
}
