SELECT LittleLemonDB.CUSTOMER.CUS_ID, CONCAT(CUS_FNAME, " ", CUS_LNAME) AS FullName, ORD_ID AS OrderID, ORD_TOTALCOST AS Cost, MENU_NAME AS MenuName, COUR_NAME AS CourseName
FROM LittleLemonDB.CUSTOMER INNER JOIN LittleLemonDB.ORDER INNER JOIN LittleLemonDB.COURSE INNER JOIN MENU
ON LittleLemonDB.CUSTOMER.MENU_ID = LittleLemonDB.ORDER.MENU_ID && LittleLemonDB.CUSTOMER.MENU_ID = LittleLemonDB.COURSE.MENU_ID
ORDER BY LittleLemonDB.ORDER.ORD_TOTALCOST DESC;
