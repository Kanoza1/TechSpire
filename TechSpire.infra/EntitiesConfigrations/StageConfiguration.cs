using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSpire.infra.EntitiesConfigrations;
public class StageConfiguration : IEntityTypeConfiguration<Stage>
{
    public void Configure(EntityTypeBuilder<Stage> builder)
    {
        builder.HasData
            (
                new Stage
                {
                    Id = 1,
                    Name = "Beginner Stage",
                },
                new Stage
                {
                    Id = 2,
                    Name = "Intermediate stage",
                },
                new Stage
                {
                    Id = 3,
                    Name = "Advanced stage",
                }
            );

    }
}

