import apollo from '../apollo'
import QUERY_SEARCH from "../graphql/SearchMedia.gql";
import QUERY_GETBYID from "../graphql/GetMediaDetails.gql";

 export const  searchMedia = async () => {
    return await apollo.query({
     query: QUERY_SEARCH,
     variables: {
 
     }
   });
 };

 export const  getById = async (id) => {
  return await apollo.query({
    query: QUERY_GETBYID,
    variables: {
      id: id,
    },
  });
};