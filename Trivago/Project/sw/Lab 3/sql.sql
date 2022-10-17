create or REPLACE PROCEDURE getcopy
(FTitle in varchar2, CID out sys_refcursor)
  as 
    BEGIN
      open CID for
        select fc.COPYID 
        from filmcopies fc, FILMTITLES f
         WHERE fc.FILMID = f.FILMID and fc.CURRENTLYRENTED = 'n' and f.FILMTITLE = FTitle;
    END;     
    
   