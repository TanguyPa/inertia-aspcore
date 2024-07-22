export default function DisplayUser(props: { id: number; firstName: string; lastName: string; }) {
    return (
        <>
            <div>
                <label>Id</label>
                <div>{ props.id}</div>
            </div>
            <div>
                <label>First name</label>
                <div>{props.firstName}</div>
            </div>
            <div>
                <label>Last name</label>
                <div>{props.lastName}</div>
            </div>
        </>
    );
}
