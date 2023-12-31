﻿using FluentMigrator;

namespace hohland_cblp.ShopBackend.Infrastructure.Migrations;

[Migration(20231212104500, "Initial migration")]
public class AddProductsTable : Migration
{
    public override void Up()
    {
        const string sql = 
            """
            CREATE TABLE IF NOT EXISTS products (
                id              bigserial PRIMARY KEY,
                name            varchar NOT NULL,
                price           numeric NOT NULL,
                currency        varchar(3) NOT NULL,
                product_type    integer NOT NULL,
                creation_date   timestamp with time zone NULL default (now() at time zone 'utc')
            );
            """;
 
        Execute.Sql(sql);
    }

    public override void Down() 
    {
        const string sql = 
            """
            DROP TABLE products;
            """;
        
        Execute.Sql(sql);
    }
}