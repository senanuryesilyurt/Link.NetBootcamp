use Week4Assignment
GO

CREATE PROCEDURE sp_GetClaims
AS
BEGIN 

SELECT op.Id, op.Name FROM OperationClaims op JOIN UserOperationClaims uop ON op.Id=uop.OperationClaimId

END