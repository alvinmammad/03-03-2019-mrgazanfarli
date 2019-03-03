import { Author } from "./author.interface";

export interface Blog {
    id: number,
    slug: string,
    title: string,
    photo: string,
    desc: string,
    date: string,
    author: Author
}