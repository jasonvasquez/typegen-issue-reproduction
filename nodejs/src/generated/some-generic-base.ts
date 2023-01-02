/**
 * This is a TypeGen auto-generated file.
 * Any changes made to this file can be lost when this file is regenerated.
 */

import { SomeTypeArgBase } from "./some-type-arg-base";

export class SomeGenericBase<ListT extends SomeTypeArgBase> {
  id: string;
  entries: ListT[];
}
