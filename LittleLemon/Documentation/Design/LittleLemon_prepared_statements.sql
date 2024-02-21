PREPARE GetOrderDetail FROM 'SELECT ORD_ID, ORD_QUANTITY, ORD_TOTALCOST FROM LittleLemonDB.ORDER 
                       WHERE ORDER.CUS_ID = ?';

SET @id = 1;
EXECUTE GetOrderDetail USING @id;


