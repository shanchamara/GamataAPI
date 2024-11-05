using Microsoft.EntityFrameworkCore.Migrations;

namespace GamataAPI.SqlViews
{
    public class SQlViewsClass
    {
        public string Vw_inquire_unread_message_count = @" CREATE VIEW Vw_inquire_unread_message_count AS 
            select `i`.`Code` AS `Inquiry_ID`,if((count(`m`.`Code`) is null),0,count(`m`.`Code`)) AS `Message_Count` from (`t_inquiry` `i` join `t_inquiry_has_message` `m` on((`i`.`Code` = `m`.`FK_Inquiry`))) where ((`i`.`IsDeleted` = 0) and (`m`.`IsView` = 0)) group by `i`.`Code`
                      ";

        public string Vw_library = @"CREATE VIEW vw_library AS 
                select `g`.`Code` AS `Code`,`g`.`Name_English` AS `Name`,count(`p`.`Code`) AS `Count` from (`m_library_has_group` `g` join `m_library_has_post` `p`) where (`g`.`Code` = `p`.`FK_Library_Group`) group by `g`.`Name_English`,`g`.`Code`";


        public string Vw_listings = @"CREATE VIEW vw_listings AS 
                    select `l`.`Code` AS `Code`,`l`.`Image` AS `Image`,`l`.`FK_Country_Code` AS `FK_Country_Code`,`l`.`FK_Country_Type` AS `FK_Country_Type`,`l`.`FK_Country_Parent` AS `FK_Country_Parent`,`l`.`Name_Sinhala` AS `Name_Sinhala`,`l`.`Name_English` AS `Name_English`,`l`.`Name_Tamil` AS `Name_Tamil`,`l`.`Group_of_Company` AS `Group_of_Company`,`l`.`IsOutlet` AS `IsOutlet`,`l`.`Product_Category` AS `Product_Category`,`l`.`Telephone` AS `Telephone`,`l`.`Whatsup` AS `Whatsup`,`l`.`Address` AS `Address`,`l`.`Products_Sinhala` AS `Products_Sinhala`,`l`.`Products_English` AS `Products_English`,`l`.`Products_Tamil` AS `Products_Tamil`,`l`.`InsertedOn` AS `InsertedOn`,`l`.`LastModifiedOn` AS `LastModifiedOn`,`l`.`LastModifiedBy` AS `LastModifiedBy`,(case when (`l`.`FK_Country_Type` = 'GRA') then `d1`.`Name_English` else NULL end) AS `grama`,`d2`.`Name_English` AS `division`,`d3`.`Name_English` AS `district`,`d4`.`Name_English` AS `province` from ((((`t_listing` `l` join `m_country_detail` `d1`) join `m_country_detail` `d2`) join `m_country_detail` `d3`) join `m_country_detail` `d4`) where (((`l`.`FK_Country_Code` = `d1`.`Code`) and (`l`.`FK_Country_Type` = 'GRA') and (`l`.`FK_Country_Parent` = `d1`.`Parent`) and (`d2`.`Code` = `d1`.`Parent`) and (`d2`.`Type` = 'DEV') and (`d3`.`Code` = `d2`.`Parent`) and (`d3`.`Type` = 'DIS') and (`d4`.`Code` = `d3`.`Parent`) and (`d4`.`Type` = 'PRO')) or ((`d1`.`Code` = 'Abasingama') and (`l`.`FK_Country_Code` = `d2`.`Code`) and (`l`.`FK_Country_Type` = 'DEV') and (`l`.`FK_Country_Parent` = `d2`.`Parent`) and (`d3`.`Code` = `d2`.`Parent`) and (`d3`.`Type` = 'DIS') and (`d4`.`Code` = `d3`.`Parent`) and (`d4`.`Type` = 'PRO')))";

        public string Vw_post_comment_count = @"CREATE VIEW vw_post_comment_count AS 
                        select `u`.`Code` AS `PostID`,if((count(`r`.`Code`) is null),0,count(`r`.`Code`)) AS `Comment_Count` from (`t_post` `u` left join `t_post_comment` `r` on((`u`.`Code` = `r`.`FK_Post_Code`))) group by `u`.`Code`";

        public string Vw_post_like_count = @"CREATE VIEW Vw_post_like_count AS 
                        select `u`.`Code` AS `PostID`,if((count(`r`.`Code`) is null),0,count(`r`.`Code`)) AS `Like_Count` from (`t_post` `u` left join `t_post_like` `r` on((`u`.`Code` = `r`.`FK_Post_Code`))) group by `u`.`Code`";

        public string vw_product = @"CREATE VIEW vw_product AS 
                        select `p1`.`Code` AS `child_code`,`p1`.`Name_English` AS `child_name_english`,`p1`.`Name_Sinhala` AS `child_name_sinhala`,`p1`.`Name_Tamil` AS `child_name_tamil`,`p1`.`Product_Description` AS `child_product_description`,`p1`.`IsSeed` AS `child_isseed`,`p1`.`Image` AS `child_Image`,`p2`.`Code` AS `parent`,`p2`.`Name_English` AS `parent_name_english`,`p3`.`Code` AS `parent1`,`p3`.`Name_English` AS `parent1_name_english` from ((`m_product` `p1` left join `m_product` `p2` on((`p1`.`Parent` = `p2`.`Code`))) left join `m_product` `p3` on((`p2`.`Parent` = `p3`.`Code`))) where (`p1`.`Parent` <> '0')";

        public string vw_product_category = @"CREATE VIEW vw_product_category AS 
                         select `t_listing`.`Product_Category` AS `Product_Category` from `t_listing` where (`t_listing`.`Status` = 'APPROVED') group by `t_listing`.`Product_Category`";


        public string vw_selling_product = @"CREATE VIEW vw_selling_product AS 
                          select (case when ((`p3`.`Code` is null) and (`p2`.`Code` is null)) then `p1`.`Code` when (`p3`.`Code` is null) then `p2`.`Code` else `p3`.`Code` end) AS `Super_Parent`,`p1`.`Type` AS `Type`,(case when ((`p3`.`Code` is null) and (`p2`.`Code` is null)) then `p1`.`Name_English` when (`p3`.`Code` is null) then `p2`.`Name_English` else `p3`.`Name_English` end) AS `Super_Parent_Name_English`,(case when ((`p3`.`Code` is null) and (`p2`.`Code` is null)) then `p1`.`Name_Sinhala` when (`p3`.`Code` is null) then `p2`.`Name_Sinhala` else `p3`.`Name_Sinhala` end) AS `Super_Parent_Name_Sinhala`,(case when ((`p3`.`Code` is null) and (`p2`.`Code` is null)) then `p1`.`Name_Tamil` when (`p3`.`Code` is null) then `p2`.`Name_Tamil` else `p3`.`Name_Tamil` end) AS `Super_Parent_Name_Tamil` from ((((`t_sell` `s` join `m_product` `p1` on((`s`.`FK_Product_Code` = `p1`.`Code`))) join `t_user` `u` on((`s`.`FK_UserID` = `u`.`RnUserID`))) left join `m_product` `p2` on((`p1`.`Parent` = `p2`.`Code`))) left join `m_product` `p3` on((`p2`.`Parent` = `p3`.`Code`))) where ((`s`.`IsActive` = 1) and (`s`.`Expired_DateTime` >= curdate()) and ((case when ((`p3`.`Code` is null) and (`p2`.`Code` is null)) then `p1`.`Code` when (`p3`.`Code` is null) then `p2`.`Code` else `p3`.`Code` end) is not null)) group by `Super_Parent`,`p1`.`Type`,`Super_Parent_Name_English`,`Super_Parent_Name_Sinhala`";

        public string vw_sell_product_inquire_count = @"CREATE VIEW vw_sell_product_inquire_count AS 
                           select `u`.`FK_Sell_Code` AS `SellID`,count(`u`.`FK_Sell_Code`) AS `InquiryCount` from `t_inquiry` `u` group by `u`.`FK_Sell_Code`";

        public string vw_user_rating = @"CREATE VIEW vw_user_rating AS 
                            select `u`.`RnUserID` AS `UserID`,`u`.`Name` AS `Name`,`u`.`ProfileImage` AS `ProfileImage`,if((avg(`r`.`Rate`) is null),5,avg(`r`.`Rate`)) AS `Rating` from (`t_user` `u` left join `t_sell_rate` `r` on((`u`.`RnUserID` = `r`.`FK_UserID`))) group by `u`.`RnUserID`,`u`.`Name`";

        public void InsertViewQuery(MigrationBuilder migrationBuilder)
        {
            var dt = new SQlViewsClass();
            migrationBuilder.Sql(dt.Vw_inquire_unread_message_count);
            migrationBuilder.Sql(dt.Vw_library);
            migrationBuilder.Sql(dt.Vw_listings);
            migrationBuilder.Sql(dt.Vw_post_comment_count);
            migrationBuilder.Sql(dt.Vw_post_like_count);
            migrationBuilder.Sql(dt.vw_product);
            migrationBuilder.Sql(dt.vw_product_category);
            migrationBuilder.Sql(dt.vw_selling_product);
            migrationBuilder.Sql(dt.vw_sell_product_inquire_count);
            migrationBuilder.Sql(dt.vw_user_rating);
        }


        public void DeleteViewQuery(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW IF EXISTS Vw_inquire_unread_message_count;");
            migrationBuilder.Sql("DROP VIEW IF EXISTS vw_library;");
            migrationBuilder.Sql("DROP VIEW IF EXISTS vw_listings;");
            migrationBuilder.Sql("DROP VIEW IF EXISTS vw_post_comment_count;");
            migrationBuilder.Sql("DROP VIEW IF EXISTS Vw_post_like_count;");
            migrationBuilder.Sql("DROP VIEW IF EXISTS vw_product;");
            migrationBuilder.Sql("DROP VIEW IF EXISTS vw_product_category;");
            migrationBuilder.Sql("DROP VIEW IF EXISTS vw_selling_product;");
            migrationBuilder.Sql("DROP VIEW IF EXISTS vw_sell_product_inquire_count;");
            migrationBuilder.Sql("DROP VIEW IF EXISTS vw_user_rating;");
        }
    }
}